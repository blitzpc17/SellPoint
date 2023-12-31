﻿using CapaDatos.ADO.Inventario;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using CapaDatos.Entidades;

namespace CapaNegocios.Logicas.Inventario
{
    public class TipoMovimientoLogica
    {

        private TipoMovimientoADO contextoTipoMov;
        public TIPO_MOVIMIENTO ObjTipoMov;
        
        public List<clsTIPOMOVIMIENTO> LstTIPO_MOVIMIENTO;
        public List<clsTIPOMOVIMIENTO> LstTIPO_MOVIMIENTOAux;

        public int index = -1;
        public int indexAux = -1;
        public int Column = 0;

        public TipoMovimientoLogica()
        {
            contextoTipoMov = new TipoMovimientoADO();
        }

        public void InstanciarTIPO_MOVIMIENTO()
        {
            ObjTipoMov = new TIPO_MOVIMIENTO();
        }

        public void Guardar()
        {
            if (ObjTipoMov.Id == 0)
            {
                contextoTipoMov.Insertar(ObjTipoMov);
            }

            contextoTipoMov.Guardar();

        }       

        public List<clsTIPOMOVIMIENTO> ListarTipos()
        {
            return contextoTipoMov.ListarTipos();
        }

        public TIPO_MOVIMIENTO Obtener(int id)
        {
            return contextoTipoMov.Obtener(id);
        }


        public bool Filtrar(int column, string termino)
        {
            if (LstTIPO_MOVIMIENTOAux == null) LstTIPO_MOVIMIENTOAux = LstTIPO_MOVIMIENTO;

            switch (column)
            {
                case 1:
                    index = LstTIPO_MOVIMIENTOAux.FindIndex(x => x.Nombre.StartsWith(termino));
                    break;

                case 2:
                    index = LstTIPO_MOVIMIENTOAux.FindIndex(x => x.Tipo.StartsWith(termino));
                    break;

                case 3:
                    index = LstTIPO_MOVIMIENTOAux.FindIndex(x => x.Activo.StartsWith(termino));
                    break;

                default:
                    index = -1;
                    break;

            }

            return (index >= 0);

        }

        public void Ordenar(int column)
        {
            switch (column)
            {

                case 1:
                    LstTIPO_MOVIMIENTOAux = LstTIPO_MOVIMIENTO.OrderBy(x => x.Nombre).ThenBy(x=>x.Tipo).ThenBy(x=>x.Activo).ToList();
                    break;

                case 2:
                    LstTIPO_MOVIMIENTOAux = LstTIPO_MOVIMIENTO.OrderBy(x => x.Tipo).ThenBy(x => x.Nombre).ThenBy(x=>x.Activo).ToList();
                    break;

                case 3:
                    LstTIPO_MOVIMIENTOAux = LstTIPO_MOVIMIENTO.OrderBy(x => x.Activo).ThenBy(x=>x.Tipo).ThenBy(x => x.Nombre).ToList();
                    break;

                default:
                    LstTIPO_MOVIMIENTOAux = LstTIPO_MOVIMIENTO.OrderBy(x => x.Nombre).ToList();
                    break;

            }
        }





    }


}
