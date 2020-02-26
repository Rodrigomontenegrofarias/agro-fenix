﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using trifenix.agro.db.interfaces;
using trifenix.agro.db.interfaces.agro.common;
using trifenix.agro.db.model.agro;
using trifenix.agro.enums;
using trifenix.agro.external.interfaces;
using trifenix.agro.external.operations.res;
using trifenix.agro.model.external;
using trifenix.agro.model.external.Input;
using trifenix.agro.search.interfaces;
using trifenix.agro.search.model;

namespace trifenix.agro.external.operations.entities.main
{
    public class TractorOperations : MainReadOperation<Tractor>, IGenericOperation<Tractor, TractorInput>
    {
        public TractorOperations(IMainGenericDb<Tractor> repo, IExistElement existElement, IAgroSearch search) : base(repo, existElement, search)
        {
        }

        public async Task<ExtPostContainer<string>> Save(TractorInput input)
        {
            var id = !string.IsNullOrWhiteSpace(input.Id) ? input.Id : Guid.NewGuid().ToString("N");

            var tractor = new Tractor
            {
                Id = id,
                Brand = input.Brand,
                Code = input.Code
            };

            if (!string.IsNullOrWhiteSpace(input.Id))
            {
                var existsId = await existElement.ExistsElement<Tractor>(input.Id);

                if (!existsId) throw new Exception(string.Format(ErrorMessages.NotValidId, "Tractor"));

                var existsCode = await existElement.ExistsEditElement<Tractor>(input.Id, "Code", input.Code);

                if (existsCode) throw new Exception("El código ya existe en otro tractor");
            }
            else
            {
                var existsCode = await existElement.ExistsElement<Tractor>("Code", input.Code);

                if (existsCode) throw new Exception("El código ya existe en otro tractor");
            }

            await repo.CreateUpdate(tractor);

            search.AddElements(new List<EntitySearch>
            {
                new EntitySearch{
                    Id = id,
                    EntityIndex = (int)EntityRelated.TRACTOR,
                    Created = DateTime.Now,
                    RelatedProperties = new Property[] {
                        new Property {
                            PropertyIndex = (int)PropertyRelated.GENERIC_BRAND,
                            Value = input.Brand
                        },
                        new Property {
                            PropertyIndex = (int)PropertyRelated.GENERIC_CODE,
                            Value = input.Code
                        }
                    }
                }
            });


            return new ExtPostContainer<string>
            {
                IdRelated = id,
                MessageResult = ExtMessageResult.Ok,
                Result = id
            };
        }
    }
}