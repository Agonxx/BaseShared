﻿using System.ComponentModel;

namespace Base.Shared.Enums
{
    public class ComumEnums
    {
        [Flags]
        public enum EGenero : uint
        {
            [Description("Masculino")]
            Masculino = 1,

            [Description("Feminino")]
            Feminino = 2,

            [Description("Outro")]
            Outro = 3,
        }


        [Flags]
        public enum ETamanho : uint
        {
            [Description("250ml")]
            Pequeno = 1,

            [Description("400ml")]
            Médio = 2,

            [Description("700ml")]
            Grande = 3,
        }
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }

            return value.ToString();
        }
    }
}
