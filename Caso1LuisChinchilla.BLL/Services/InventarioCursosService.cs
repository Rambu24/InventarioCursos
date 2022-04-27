using Caso1LuisChinchilla.BLL.Models;
using Caso1LuisChinchilla.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1LuisChinchilla.BLL.Services
{
    public class InventarioCursosService
    {
        private readonly Caso1_LuisChinchillaContext InventarioDBContext;

        public InventarioCursosService(Caso1_LuisChinchillaContext InventarioDBContext)
        {
            this.InventarioDBContext = InventarioDBContext;

        }


        //Este Task  es el que devuelve una lista
        public async Task<List<InventarioCursosListModel>> GetAllInventario_CursosAsync()
        {
            return await InventarioDBContext.InventarioCursos.Select(
                s => new InventarioCursosListModel
                {
                    Nombre_Carrera = s.NombreCarrera,
                    Codigo_Asignatura = s.CodigoAsignatura,
                    Nombre_Asignatura = s.NombreAsignatura,
                    Creditos = s.Creditos,
                    Cuatrimestre = s.Cuatrimestre,
                    Duracion_Semanas = s.DuracionSemanas,
                    Horas_Semanales = s.HorasSemanales,
                    Nombre_Docente = s.NombreDocente,
                    Correo = s.Correo,
                    Fecha_Inicio = s.FechaInicio,
                    Fecha_Final = s.FechaFinal,
                    Active = s.Active
                }).Where(p => p.Active == true).ToListAsync();
        }

        //Este Task se usa para el Datos_CarreraDetailModelCLS
        public async Task<InventarioCursosDetailModel> GetInventario_CursosByIdAsync(int cursoId)
        {

            return await InventarioDBContext.InventarioCursos.Select(
                s => new InventarioCursosDetailModel
                {
                    Nombre_Carrera = s.NombreCarrera,
                    Codigo_Asignatura = s.CodigoAsignatura,
                    Nombre_Asignatura = s.NombreAsignatura,
                    Creditos = s.Creditos,
                    Cuatrimestre = s.Cuatrimestre,
                    Duracion_Semanas = s.DuracionSemanas,
                    Horas_Semanales = s.HorasSemanales,
                    Nombre_Docente = s.NombreDocente,
                    Correo = s.Correo,
                    Fecha_Inicio = s.FechaInicio,
                    Fecha_Final = s.FechaFinal
                }).FirstOrDefaultAsync(s => s.Codigo_Asignatura == cursoId);
        }       

        

        

        //Task para realizar una inserción a la instancia de la clase DatosCarreraDetailModelCLS
        public async Task InsertInventario_CursosAsync(InventarioCursosDetailModel inventario_Cursos)
        {
            var entity = new InventarioCurso()
            {

                CodigoAsignatura = inventario_Cursos.Codigo_Asignatura,
                NombreCarrera = inventario_Cursos.Nombre_Carrera,
                NombreAsignatura = inventario_Cursos.Nombre_Asignatura,
                Creditos = inventario_Cursos.Creditos,
                Cuatrimestre = inventario_Cursos.Cuatrimestre,
                DuracionSemanas = inventario_Cursos.Duracion_Semanas,
                HorasSemanales = inventario_Cursos.Horas_Semanales,
                NombreDocente = inventario_Cursos.Nombre_Docente,
                Correo = inventario_Cursos.Correo,
                FechaInicio = inventario_Cursos.Fecha_Inicio,
                FechaFinal = inventario_Cursos.Fecha_Final,
                Active = true
            };
            InventarioDBContext.InventarioCursos.Add(entity);
            await InventarioDBContext.SaveChangesAsync();
        }


        //Task para realizar un update
        public async Task UpdateInventario_CursosAsync(InventarioCursosDetailModel inventario_Cursos)
        {
            var entity = await InventarioDBContext.InventarioCursos.FirstOrDefaultAsync(s => s.CodigoAsignatura == inventario_Cursos.Codigo_Asignatura);

            entity.CodigoAsignatura = inventario_Cursos.Codigo_Asignatura;
            entity.NombreCarrera = inventario_Cursos.Nombre_Carrera;
            entity.NombreAsignatura = inventario_Cursos.Nombre_Asignatura;
            entity.Creditos = inventario_Cursos.Creditos;
            entity.Cuatrimestre = inventario_Cursos.Cuatrimestre;
            entity.DuracionSemanas = inventario_Cursos.Duracion_Semanas;
            entity.HorasSemanales = inventario_Cursos.Horas_Semanales;
            entity.NombreDocente = inventario_Cursos.Nombre_Docente;
            entity.Correo = inventario_Cursos.Correo;
            entity.FechaInicio = inventario_Cursos.Fecha_Inicio;
            entity.FechaFinal = inventario_Cursos.Fecha_Final;


            await InventarioDBContext.SaveChangesAsync();
        }

        //Task para eliminar un registro
        public async Task DeleteInventario_CursosAsync(InventarioCursosDetailModel inventario_Cursos)
        {
            var entity = await InventarioDBContext.InventarioCursos.FirstOrDefaultAsync(s => s.CodigoAsignatura == inventario_Cursos.Codigo_Asignatura);

            entity.Active = false;


            //var entity = new InventarioCurso()
            //{
            //    CodigoAsignatura = codigoAsignatura
            //};

            //CarrerasDBContext.InventarioCursos.Attach(entity);
            //CarrerasDBContext.InventarioCursos.Remove(entity);

            await InventarioDBContext.SaveChangesAsync();
        }

    }
}
