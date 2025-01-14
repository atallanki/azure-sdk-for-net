// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayFirewallManifestRuleSet
    {
        internal static ApplicationGatewayFirewallManifestRuleSet DeserializeApplicationGatewayFirewallManifestRuleSet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleSetType = default;
            string ruleSetVersion = default;
            Optional<ApplicationGatewayRuleSetStatusOption> status = default;
            Optional<IReadOnlyList<ApplicationGatewayTierType>> tiers = default;
            IReadOnlyList<ApplicationGatewayFirewallRuleGroup> ruleGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleSetType"u8))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"u8))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ApplicationGatewayRuleSetStatusOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tiers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayTierType> array = new List<ApplicationGatewayTierType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApplicationGatewayTierType(item.GetString()));
                    }
                    tiers = array;
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    List<ApplicationGatewayFirewallRuleGroup> array = new List<ApplicationGatewayFirewallRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayFirewallRuleGroup.DeserializeApplicationGatewayFirewallRuleGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
            }
            return new ApplicationGatewayFirewallManifestRuleSet(ruleSetType, ruleSetVersion, Optional.ToNullable(status), Optional.ToList(tiers), ruleGroups);
        }
    }
}
