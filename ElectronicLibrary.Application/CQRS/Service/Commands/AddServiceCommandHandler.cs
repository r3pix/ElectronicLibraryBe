﻿using AutoMapper;
using ElectronicLibrary.Application.Interfaces;
using ElectronicLibrary.Infrastructure.Models;
using ElectronicLibrary.Infrastructure.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElectronicLibrary.Application.CQRS.Service.Commands
{
    public class AddServiceCommandHandler : IRequestHandler<AddServiceCommand>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IRepository<ElectronicBookingSystem.Domain.Entities.File> _fileRepository;
        private readonly IMapper _mapper;

        public AddServiceCommandHandler(IServiceRepository serviceRepository, IRepository<ElectronicBookingSystem.Domain.Entities.File> fileRepository, IFileService fileService,
            IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _fileRepository = fileRepository;           
            _mapper = mapper;
        
        }

        public async Task<Unit> Handle(AddServiceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ElectronicBookingSystem.Domain.Entities.Service>(request);
            await _serviceRepository.Save(entity);
            return default;
        }
    }
}
