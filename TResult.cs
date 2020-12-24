/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Thrift
{

  /// <summary>
  /// if no Result is found, row and columnValues will not be set.
  /// </summary>
  public partial class TResult : TBase
  {
    private byte[] _row;

    public byte[] Row
    {
      get
      {
        return _row;
      }
      set
      {
        __isset.row = true;
        this._row = value;
      }
    }

    public List<TColumnValue> ColumnValues { get; set; }


    public Isset __isset;
    public struct Isset
    {
      public bool row;
    }

    public TResult()
    {
    }

    public TResult(List<TColumnValue> columnValues) : this()
    {
      this.ColumnValues = columnValues;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_columnValues = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Row = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                  ColumnValues = new List<TColumnValue>(_list0.Count);
                  for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    TColumnValue _elem2;
                    _elem2 = new TColumnValue();
                    await _elem2.ReadAsync(iprot, cancellationToken);
                    ColumnValues.Add(_elem2);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_columnValues = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_columnValues)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TResult");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Row != null && __isset.row)
        {
          field.Name = "row";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(Row, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        field.Name = "columnValues";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, ColumnValues.Count), cancellationToken);
          foreach (TColumnValue _iter3 in ColumnValues)
          {
            await _iter3.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as TResult;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.row == other.__isset.row) && ((!__isset.row) || (TCollections.Equals(Row, other.Row))))
        && TCollections.Equals(ColumnValues, other.ColumnValues);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.row)
          hashcode = (hashcode * 397) + Row.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ColumnValues);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TResult(");
      bool __first = true;
      if (Row != null && __isset.row)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Row: ");
        sb.Append(Row);
      }
      if(!__first) { sb.Append(", "); }
      sb.Append("ColumnValues: ");
      sb.Append(ColumnValues);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
