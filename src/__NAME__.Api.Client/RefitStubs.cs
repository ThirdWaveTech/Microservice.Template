﻿﻿using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using __NAME__.Messages.Models;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

namespace RefitInternalGenerated
{
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {
#pragma warning disable 0649
        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
#pragma warning restore 0649
    }
}

namespace __NAME__.Api.Client.ResourceClients
{
    using RefitInternalGenerated;

    [Preserve]
    public partial class AutoGeneratedIApiInfoClient : IApiInfoClient
    {
        public HttpClient Client { get; protected set; }
        readonly Dictionary<string, Func<HttpClient, object[], object>> methodImpls;

        public AutoGeneratedIApiInfoClient(HttpClient client, IRequestBuilder requestBuilder)
        {
            methodImpls = requestBuilder.InterfaceHttpMethods.ToDictionary(k => k, v => requestBuilder.BuildRestResultFuncForMethod(v));
            Client = client;
        }

        public virtual Task<string> Get()
        {
            var arguments = new object[] {  };
            return (Task<string>) methodImpls["Get"](Client, arguments);
        }

        public virtual Task Post(RegisterClientModel registerClientModel,string token)
        {
            var arguments = new object[] { registerClientModel,token };
            return (Task) methodImpls["Post"](Client, arguments);
        }

    }
}

