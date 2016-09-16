﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Board
{
    public Field StartWhite { get; set; }

    public Field StartBlack { get; set; }

    public Board()
    {
        StartWhite = new Field();
        var field = StartWhite;

        Dictionary<int, FieldType> exceptions = new Dictionary<int, FieldType>();
        exceptions.Add(3, FieldType.Roset);
        exceptions.Add(7, FieldType.Roset);
        exceptions.Add(11, FieldType.Split);
        exceptions.Add(13, FieldType.Roset);

        FieldType type;

        for (int i = 1; i < 13; i++)
        {
            field.NextField = new Field();
            if(exceptions.TryGetValue(i, out type))
            {
                field.Type = type;
            }
            field = field.NextField;
        }

        //Black fields matter

    }

}

