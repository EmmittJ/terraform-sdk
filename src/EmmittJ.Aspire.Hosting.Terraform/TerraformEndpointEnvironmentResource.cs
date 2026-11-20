// Licensed under the MIT License.

#pragma warning disable ASPIRECOMPUTE002

using System.Diagnostics.CodeAnalysis;
using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

[Experimental(TerraformDiagnostics.Experimental)]
internal sealed class TerraformEndpointEnvironmentResource(TerraformModuleResource module)
    : Resource($"{module.Name}-endpoints"), IComputeEnvironmentResource
{
    public ReferenceExpression GetHostAddressExpression(EndpointReference endpointReference)
        => GetEndpointPropertyExpression(endpointReference.Property(EndpointProperty.Host));

    public ReferenceExpression GetEndpointPropertyExpression(EndpointReferenceExpression endpointReferenceExpression)
    {
        var endpoint = endpointReferenceExpression.Endpoint;
        if (!ReferenceEquals(endpoint.Resource, module.TargetResource))
        {
            throw new InvalidOperationException($"Endpoint '{endpoint.EndpointName}' does not belong to '{module.TargetResource?.Name}'.");
        }

        var output = module.GetEndpointOutput(endpoint.EndpointName, endpointReferenceExpression.Property);
        return ReferenceExpression.Create($"{new TerraformModuleOutputReference(output, module)}");
    }
}
