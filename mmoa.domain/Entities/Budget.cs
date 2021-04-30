﻿using mmoa.Domain.Entities.Base;
using mmoa.Domain.Enums;
using System;

namespace mmoa.Domain.Entities
{
    public class Budget:EntityBase
    {
        public Budget()
        {            
        }
        
        public Budget(string name, DurationType durationType, int duration, DateTime startDate, bool isActive, Budget parent, Person person)
        {
            Name = name;
            DurationType = durationType;
            Duration = duration;
            StartDate = startDate;
            IsActive = isActive;
            Parent = parent;
            Person = person;
        }

        public string Name { get; private set; }

        public DurationType DurationType { get; set; }

        public int Duration { get; private set; }

        public DateTime StartDate { get; private set; }

        public bool IsActive { get; private set; }

        public Budget Parent { get; private set; }

        public Person Person { get; private set; }
    }
}
