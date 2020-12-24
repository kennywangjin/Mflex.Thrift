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


namespace Mflex.Thrift
{

    /// <summary>
    /// Used to perform Increment operations for a single row.
    /// 
    /// You can specify how this Increment should be written to the write-ahead Log (WAL)
    /// by changing the durability. If you don't provide durability, it defaults to
    /// column family's default setting for durability.
    /// </summary>
    public partial class TIncrement : TBase
    {
        private Dictionary<byte[], byte[]> _attributes;
        private TDurability _durability;
        private TCellVisibility _cellVisibility;

        public byte[] Row { get; set; }

        public List<TColumnIncrement> Columns { get; set; }

        public Dictionary<byte[], byte[]> Attributes
        {
            get
            {
                return _attributes;
            }
            set
            {
                __isset.attributes = true;
                this._attributes = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TDurability"/>
        /// </summary>
        public TDurability Durability
        {
            get
            {
                return _durability;
            }
            set
            {
                __isset.durability = true;
                this._durability = value;
            }
        }

        public TCellVisibility CellVisibility
        {
            get
            {
                return _cellVisibility;
            }
            set
            {
                __isset.cellVisibility = true;
                this._cellVisibility = value;
            }
        }


        public Isset __isset;
        public struct Isset
        {
            public bool attributes;
            public bool durability;
            public bool cellVisibility;
        }

        public TIncrement()
        {
        }

        public TIncrement(byte[] row, List<TColumnIncrement> columns) : this()
        {
            this.Row = row;
            this.Columns = columns;
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();
            try
            {
                bool isset_row = false;
                bool isset_columns = false;
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
                                isset_row = true;
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
                                    TList _list35 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Columns = new List<TColumnIncrement>(_list35.Count);
                                    for (int _i36 = 0; _i36 < _list35.Count; ++_i36)
                                    {
                                        TColumnIncrement _elem37;
                                        _elem37 = new TColumnIncrement();
                                        await _elem37.ReadAsync(iprot, cancellationToken);
                                        Columns.Add(_elem37);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                                isset_columns = true;
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.Map)
                            {
                                {
                                    TMap _map38 = await iprot.ReadMapBeginAsync(cancellationToken);
                                    Attributes = new Dictionary<byte[], byte[]>(_map38.Count);
                                    for (int _i39 = 0; _i39 < _map38.Count; ++_i39)
                                    {
                                        byte[] _key40;
                                        byte[] _val41;
                                        _key40 = await iprot.ReadBinaryAsync(cancellationToken);
                                        _val41 = await iprot.ReadBinaryAsync(cancellationToken);
                                        Attributes[_key40] = _val41;
                                    }
                                    await iprot.ReadMapEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I32)
                            {
                                Durability = (TDurability)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.Struct)
                            {
                                CellVisibility = new TCellVisibility();
                                await CellVisibility.ReadAsync(iprot, cancellationToken);
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
                if (!isset_row)
                {
                    throw new TProtocolException(TProtocolException.INVALID_DATA);
                }
                if (!isset_columns)
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
                var struc = new TStruct("TIncrement");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                field.Name = "row";
                field.Type = TType.String;
                field.ID = 1;
                await oprot.WriteFieldBeginAsync(field, cancellationToken);
                await oprot.WriteBinaryAsync(Row, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
                field.Name = "columns";
                field.Type = TType.List;
                field.ID = 2;
                await oprot.WriteFieldBeginAsync(field, cancellationToken);
                {
                    await oprot.WriteListBeginAsync(new TList(TType.Struct, Columns.Count), cancellationToken);
                    foreach (TColumnIncrement _iter42 in Columns)
                    {
                        await _iter42.WriteAsync(oprot, cancellationToken);
                    }
                    await oprot.WriteListEndAsync(cancellationToken);
                }
                await oprot.WriteFieldEndAsync(cancellationToken);
                if (Attributes != null && __isset.attributes)
                {
                    field.Name = "attributes";
                    field.Type = TType.Map;
                    field.ID = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Attributes.Count), cancellationToken);
                        foreach (byte[] _iter43 in Attributes.Keys)
                        {
                            await oprot.WriteBinaryAsync(_iter43, cancellationToken);
                            await oprot.WriteBinaryAsync(Attributes[_iter43], cancellationToken);
                        }
                        await oprot.WriteMapEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.durability)
                {
                    field.Name = "durability";
                    field.Type = TType.I32;
                    field.ID = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Durability, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (CellVisibility != null && __isset.cellVisibility)
                {
                    field.Name = "cellVisibility";
                    field.Type = TType.Struct;
                    field.ID = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await CellVisibility.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
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
            var other = that as TIncrement;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return TCollections.Equals(Row, other.Row)
              && TCollections.Equals(Columns, other.Columns)
              && ((__isset.attributes == other.__isset.attributes) && ((!__isset.attributes) || (TCollections.Equals(Attributes, other.Attributes))))
              && ((__isset.durability == other.__isset.durability) && ((!__isset.durability) || (System.Object.Equals(Durability, other.Durability))))
              && ((__isset.cellVisibility == other.__isset.cellVisibility) && ((!__isset.cellVisibility) || (System.Object.Equals(CellVisibility, other.CellVisibility))));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;
            unchecked
            {
                hashcode = (hashcode * 397) + Row.GetHashCode();
                hashcode = (hashcode * 397) + TCollections.GetHashCode(Columns);
                if (__isset.attributes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Attributes);
                if (__isset.durability)
                    hashcode = (hashcode * 397) + Durability.GetHashCode();
                if (__isset.cellVisibility)
                    hashcode = (hashcode * 397) + CellVisibility.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("TIncrement(");
            sb.Append(", Row: ");
            sb.Append(Row);
            sb.Append(", Columns: ");
            sb.Append(Columns);
            if (Attributes != null && __isset.attributes)
            {
                sb.Append(", Attributes: ");
                sb.Append(Attributes);
            }
            if (__isset.durability)
            {
                sb.Append(", Durability: ");
                sb.Append(Durability);
            }
            if (CellVisibility != null && __isset.cellVisibility)
            {
                sb.Append(", CellVisibility: ");
                sb.Append(CellVisibility == null ? "<null>" : CellVisibility.ToString());
            }
            sb.Append(")");
            return sb.ToString();
        }
    }

}
