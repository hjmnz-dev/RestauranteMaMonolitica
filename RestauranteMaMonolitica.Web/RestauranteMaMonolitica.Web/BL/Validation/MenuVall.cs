using RestauranteMaMonolitica.Web.BL.Core;
using RestauranteMaMonolitica.Web.BL.IMenuVal;
using RestauranteMaMonolitica.Web.Data.Models;

namespace RestauranteMaMonolitica.Web.BL.Validation
{
    public class MenuVall : IMenuVall
    {
        public void MenuGetMenu()
        {
            var menu = new MenuGetModel();
           ServiceResult result = new ServiceResult();
            if (!menu.IdPlato.HasValue)
            {
                result.success = false;
                result.Messge = "El nombre no es nulo";
            }

            if (menu.Nombre.Length > 50)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 50";
            }

            if (menu.Descripcion.Length > 100)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 100";
            }

            if (menu.Precio.HasValue)
            {
                decimal precio = menu.Precio.Value;
                int decimals = BitConverter.GetBytes(decimal.GetBits(precio)[3])[2];


                if (decimals > 2)
                {
                    result.success = false;
                    result.Messge = "El valor tiene más de dos decimales.";
                }
                else if (precio > 100)
                {
                    result.success = false;
                    result.Messge = "Valor mayor del límite de 100.";
                }
                else
                {
                    result.success = true;
                    result.Messge = "El valor es válido.";
                }
            }
            else
            {
                result.success = false;
                result.Messge = "El precio no puede ser nulo.";
            }
            result.success = false;
            result.Messge = "Valor mayor del limite de 100";


            if (menu.Categoria.Length > 20)
            {
                result.success = false;
                result.Messge = "El valor de Categoria paso de los del limite de 20";
            }
        }

        public void MenuGetValidatios(int id)
        {
            var menu = new MenuGetModel();
            ServiceResult result = new ServiceResult();
            if (!menu.IdPlato.HasValue)
            {
                result.success = false;
                result.Messge = "El nombre no es nulo";
            }

            if (menu.Nombre.Length > 50)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 50";
            }

            if (menu.Descripcion.Length > 100)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 100";
            }

            if (menu.Precio.HasValue)
            {
                decimal precio = menu.Precio.Value;
                int decimals = BitConverter.GetBytes(decimal.GetBits(precio)[3])[2];


                if (decimals > 2)
                {
                    result.success = false;
                    result.Messge = "El valor tiene más de dos decimales.";
                }
                else if (precio > 100)
                {
                    result.success = false;
                    result.Messge = "Valor mayor del límite de 100.";
                }
                else
                {
                    result.success = true;
                    result.Messge = "El valor es válido.";
                }
            }
            else
            {
                result.success = false;
                result.Messge = "El precio no puede ser nulo.";
            }
            result.success = false;
            result.Messge = "Valor mayor del limite de 100";


            if (menu.Categoria.Length > 20)
            {
                result.success = false;
                result.Messge = "El valor de Categoria paso de los del limite de 20";
            }
        }

        public void MenuSaveValidation(MenuSaveModel menuSave)
        {
            ServiceResult result = new ServiceResult();
            if (!menuSave.IdPlato.HasValue)
            {
                result.success = false;
                result.Messge = "El nombre no es nulo";
            }

            if (menuSave.Nombre.Length > 50)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 50";
            }

            if (menuSave.Descripcion.Length > 100)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 100";
            }

            if (menuSave.Precio.HasValue)
            {
                decimal precio = menuSave.Precio.Value;
                int decimals = BitConverter.GetBytes(decimal.GetBits(precio)[3])[2];


                if (decimals < 2)
                {
                    result.success = false;
                    result.Messge = "El valor tiene más de dos decimales.";
                }
                else if (precio > 10)
                {
                    result.success = false;
                    result.Messge = "Valor mayor del límite de 10.";
                }
                else
                {
                    result.success = true;
                    result.Messge = "El valor es válido.";
                }
            }
            else
            {
                result.success = false;
                result.Messge = "El precio no puede ser nulo.";
            }
            result.success = false;
            result.Messge = "Valor mayor del limite de 100";


            if (menuSave.Categoria.Length > 20)
            {
                result.success = false;
                result.Messge = "El valor de Categoria paso de los del limite de 20";
            }
        }

        public void MenuUpdateValidation(MenuUpdateModel menuUpdate)
        {
            ServiceResult result = new ServiceResult();
            if (!menuUpdate.IdPlato.HasValue)
            {
                result.success = false;
                result.Messge = "El nombre no es nulo";
            }

            if (!menuUpdate.CreationUser.HasValue)
            {
                result.success = false;
                result.Messge = "El User del creador no puede ser nulo";
            }

            if (menuUpdate.Nombre.Length > 50)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 50";
            }

            if (menuUpdate.Descripcion.Length > 100)
            {
                result.success = false;
                result.Messge = "Valor mayor del limite de 100";
            }

            if (menuUpdate.Precio.HasValue)
            {
                decimal precio = menuUpdate.Precio.Value;
                int decimals = BitConverter.GetBytes(decimal.GetBits(precio)[3])[2];


                if (decimals < 2)
                {
                    result.success = false;
                    result.Messge = "El valor tiene más de dos decimales.";
                }
                else if (precio > 10)
                {
                    result.success = false;
                    result.Messge = "Valor mayor del límite de 10.";
                }
                else
                {
                    result.success = true;
                    result.Messge = "El valor es válido.";
                }
            }
            else
            {
                result.success = false;
                result.Messge = "El precio no puede ser nulo.";
            }
            result.success = false;
            result.Messge = "Valor mayor del limite de 100";


            if (menuUpdate.Categoria.Length > 20)
            {
                result.success = false;
                result.Messge = "El valor de Categoria paso de los del limite de 20";
            }
        }
    }
}
