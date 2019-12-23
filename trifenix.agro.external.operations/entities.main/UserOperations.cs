﻿using System.Collections.Generic;
using System.Threading.Tasks;
using trifenix.agro.db.interfaces.agro;
using trifenix.agro.db.interfaces.common;
using trifenix.agro.db.model.agro;
using trifenix.agro.external.interfaces.entities.main;
using trifenix.agro.external.operations.helper;
using trifenix.agro.model.external;

namespace trifenix.agro.external.operations.entities.main
{
    public class UserOperations : IUserOperations
    {
        private readonly IUserRepository _repo;
        private readonly IJobRepository _repoJob;
        private readonly IRoleRepository _repoRole;
        private readonly INebulizerRepository _repoNebulizer;
        private readonly ITractorRepository _repoTractor;
        private readonly ICommonDbOperations<User> _commonDb;
        public UserOperations(IUserRepository repo, IJobRepository repoJob, IRoleRepository repoRole, INebulizerRepository repoNebulizer, ITractorRepository repoTractor, ICommonDbOperations<User> commonDb)
        {
            _repo = repo;
            _repoJob = repoJob;
            _repoRole = repoRole;
            _repoNebulizer = repoNebulizer;
            _repoTractor = repoTractor;
            _commonDb = commonDb;
        }

        public async Task<ExtGetContainer<User>> GetUser(string id)
        {
            var user = await _repo.GetUser(id);
            return OperationHelper.GetElement(user);
        }

        public async Task<ExtGetContainer<List<User>>> GetUsers()
        {
            var queryTargets = _repo.GetUsers();
            var targets = await _commonDb.TolistAsync(queryTargets);
            return OperationHelper.GetElements(targets);
        }

        public async Task<ExtPostContainer<User>> SaveEditUser(string id, string name, string rut, string email, string idJob, string[] idsRoles, string idNebulizer, string idTractor)
        {
            Job job = await _repoJob.GetJob(idJob);
            if (job == null)
                return OperationHelper.PostNotFoundElementException<User>($"No se encontró el cargo con id {idJob}", idJob);
            List<Role> roles = new List<Role>();
            Role role;
            foreach (string idRole in idsRoles)
            {
                role = await _repoRole.GetRole(idRole);
                if (role == null)
                    return OperationHelper.PostNotFoundElementException<User>($"No se encontró el rol con id {idRole}", idRole);
                roles.Add(role);
            }
            bool isApplicator = roles.Exists(r => r.Name.Equals("Aplicador"));
            Nebulizer nebulizer = null;
            Tractor tractor = null;
            if (isApplicator)
            {
                nebulizer = await _repoNebulizer.GetNebulizer(idNebulizer);
                if (nebulizer == null)
                    return OperationHelper.PostNotFoundElementException<User>($"No se encontró la nebulizadora con id {idNebulizer}", idNebulizer);
                tractor = await _repoTractor.GetTractor(idTractor);
                if (tractor == null)
                    return OperationHelper.PostNotFoundElementException<User>($"No se encontró el tractor con id {idTractor}", idTractor);
            }
            var element = await _repo.GetUser(id);
            return await OperationHelper.EditElement(id,
                element,
                s => {
                    s.Name = name;
                    s.Rut = rut;
                    s.Email = email;
                    s.Job = job;
                    s.Roles = roles;
                    return s;
                },
                _repo.CreateUpdateUser,
                 $"No existe objetivo aplicación con id : {id}"
            );
        }

        public async Task<ExtPostContainer<string>> SaveNewUser(string name, string rut, string email, string idJob, string[] idsRoles, string idNebulizer, string idTractor)
        {
            Job job = await _repoJob.GetJob(idJob);
            if (job == null)
                return OperationHelper.PostNotFoundElementException<string>($"No se encontró el cargo con id {idJob}", idJob);
            List<Role> roles = new List<Role>();
            Role role;
            foreach (string idRole in idsRoles)
            {
                role = await _repoRole.GetRole(idRole);
                if (role == null)
                    return OperationHelper.PostNotFoundElementException<string>($"No se encontró el rol con id {idRole}", idRole);
                roles.Add(role);
            }
            bool isApplicator = roles.Exists(r => r.Name.Equals("Aplicador"));
            Nebulizer nebulizer = null;
            Tractor tractor = null;
            if (isApplicator){
                nebulizer = await _repoNebulizer.GetNebulizer(idNebulizer);
                if (nebulizer == null)
                    return OperationHelper.PostNotFoundElementException<string>($"No se encontró la nebulizadora con id {idNebulizer}", idNebulizer);
                tractor = await _repoTractor.GetTractor(idTractor);
                if (tractor == null)
                    return OperationHelper.PostNotFoundElementException<string>($"No se encontró el tractor con id {idTractor}", idTractor);
            }
            return await OperationHelper.CreateElement(_commonDb,_repo.GetUsers(),
                async s => await _repo.CreateUpdateUser(isApplicator?
                        new UserApplicator{
                            Id = s,
                            Name = name,
                            Rut = rut,
                            Email = email,
                            Job = job,
                            Roles = roles,
                            Nebulizer = nebulizer,
                            Tractor = tractor
                        }:
                        new User{
                            Id = s,
                            Name = name,
                            Rut = rut,
                            Email = email,
                            Job = job,
                            Roles = roles
                        }),
                s => s.Name.Equals(name) || s.Rut.Equals(rut),
                $"Este nombre o rut ya existe"
            );
        }
    }
}