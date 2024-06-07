﻿using RestauranteMaMonolitica.Web.Data.Context;
using RestauranteMaMonolitica.Web.Data.Entities;
using RestauranteMaMonolitica.Web.Data.Interfaces;
using RestauranteMaMonolitica.Web.Data.Models;
using RestauranteMaMonolitica.Web.Data.Repositories;

namespace RestauranteMaMonolitica.Web.Data.DbObjects
{
    public class EmpleadoDb : IEmpleadoDb
    {
        private readonly EmpleadoRepositories _empleadoRepositories;

        public EmpleadoDb(EmpleadoRepositories empleadoRepositories) { 

            this._empleadoRepositories = empleadoRepositories;

        }
        public async Task<EmpleadoModel>GetEmpleado(int idEmpleado)
        {
            return await _empleadoRepositories.GetEmpleado(idEmpleado);
        }

        public List<EmpleadoModel> GetEmpleados()
        {
            return _empleadoRepositories.GetEmpleados();
        }

        public void SaveEmpleado(EmpleadoSaveModel empleadoSaveModel)
        {
            _empleadoRepositories.SaveEmpleado(empleadoSaveModel);
        }

        public void UpdateEmpleado(EmpleadoUpdateModel empleadoUpdateModel)
        {
            _empleadoRepositories.UpdateEmpleado(empleadoUpdateModel);
        }
        public void RemoveEmpleado(EmpleadoRemoveModel empleadoRemoveModel)
        {
            _empleadoRepositories.RemoveEmpleado(empleadoRemoveModel);
        }

    }
}
