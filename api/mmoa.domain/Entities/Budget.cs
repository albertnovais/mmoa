using mmoa.Domain.Entities.Base;
using mmoa.Domain.Enums;
using System;

namespace mmoa.Domain.Entities
{
    public class Budget:EntityBase
    {
        public Budget()
        {            
        }
        
        public Budget(string name, DurationType durationType, int duration, DateTime startDate, bool isActive, Budget parent, User user)
        {
            Name = name;
            DurationType = durationType;
            Duration = duration;
            StartDate = startDate;
            IsActive = isActive;
            Parent = parent;
            User = user;
        }

        public string Name { get; private set; }

        public DurationType DurationType { get; set; }

        public int Duration { get; private set; }

        public DateTime StartDate { get; private set; }

        public bool IsActive { get; private set; }

        public Budget Parent { get; private set; }

        public User User { get; private set; }
    }
}
