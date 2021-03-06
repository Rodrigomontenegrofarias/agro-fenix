﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace trifenix.connect.agro.interfaces
{
    /// <summary>
    /// Consultas comunes a base de datos, para agroFenix
    /// </summary>
    public interface ICommonAgroQueries {

        

        /// <summary>
        /// Obtiene los corroeos desde los roles.
        /// </summary>
        /// <param name="idsRoles">identificador de roles</param>
        /// <returns></returns>
        Task<List<string>> GetUsersMailsFromRoles(List<string> idsRoles);

        /// <summary>
        /// obtiene el season id desde barrack
        /// </summary>
        /// <param name="idBarrack">identificador de barrack</param>
        /// <returns></returns>
        Task<string> GetSeasonId(string idBarrack);


        /// <summary>
        /// Obtiene el identificador de usuario desde el id de active directory.
        /// </summary>
        /// <param name="idAAD">identificador de active directory</param>
        /// <returns>identificador del usuario</returns>
        Task<string> GetUserIdFromAAD(string idAAD);

        /// <summary>
        /// Obtiene la dosis por defecto de un producto
        /// </summary>
        /// <param name="idProduct">identificador de producto, donde buscar la dosis</param>
        /// <returns></returns>
        Task<string> GetDefaultDosesId(string idProduct);


        /// <summary>
        /// Obtiene las dosis activas de un producto
        /// </summary>
        /// <param name="idProduct">identificador del producto</param>
        /// <returns>identificadores de las dosis activas</returns>
        Task<IEnumerable<string>> GetActiveDosesIdsFromProductId(string idProduct);

        



    }

}