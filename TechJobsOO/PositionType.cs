﻿using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            this.Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.

        public override string ToString()
        {
            return Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
                Id == positionType.Id;
           
        }
    }
}
