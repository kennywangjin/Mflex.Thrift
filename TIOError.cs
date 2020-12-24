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
    /// A TIOError exception signals that an error occurred communicating
    /// to the HBase master or a HBase region server. Also used to return
    /// more general HBase error conditions.
    /// </summary>
    public partial class TIOError : TException, TBase
    {
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                __isset.message = true;
                this._message = value;
            }
        }


        public Isset __isset;
        public struct Isset
        {
            public bool message;
        }

        public TIOError()
        {
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();
            try
            {
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
                                Message = await iprot.ReadStringAsync(cancellationToken);
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
                var struc = new TStruct("TIOError");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (Message != null && __isset.message)
                {
                    field.Name = "message";
                    field.Type = TType.String;
                    field.ID = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteStringAsync(Message, cancellationToken);
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
            var other = that as TIOError;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((__isset.message == other.__isset.message) && ((!__isset.message) || (System.Object.Equals(Message, other.Message))));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;
            unchecked
            {
                if (__isset.message)
                    hashcode = (hashcode * 397) + Message.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("TIOError(");
            bool __first = true;
            if (Message != null && __isset.message)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Message: ");
                sb.Append(Message);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }

}
