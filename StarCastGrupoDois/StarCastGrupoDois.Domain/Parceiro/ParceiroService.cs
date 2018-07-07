﻿using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Application.Repository.Parceiro;
using StarCastGrupoDois.Domain.Core;

namespace StarCastGrupoDois.Domain.Parceiro
{

    public class ParceiroService : ServiceBase<StarCastGrupoDois.Domain.Entities.Models.Parceiro>, Application.Domain.Parceiro.IParceiroService
    {
        private readonly IParceiroRepositorio _parceiroRepositorio;


        public ParceiroService(IParceiroRepositorio parceiroRepositorio, IUnitOfWork uow) : base(uow)
        {
            _parceiroRepositorio = parceiroRepositorio;
        }
        public override void Salvar(StarCastGrupoDois.Domain.Entities.Models.Parceiro obj)
        {
            obj.CriarNovoCodigo();
            _parceiroRepositorio.Add(obj);

            Commit();

        }
    }
}