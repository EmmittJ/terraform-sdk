using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opensearch_authorize_vpc_endpoint_access resource.
/// </summary>
public class AwsOpensearchAuthorizeVpcEndpointAccess : TerraformResource
{
    public AwsOpensearchAuthorizeVpcEndpointAccess(string name) : base("aws_opensearch_authorize_vpc_endpoint_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("authorized_principal");
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    public string? Account
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account")?.Value;
        set => this.WithProperty("account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorized_principal attribute.
    /// </summary>
    public TerraformExpression AuthorizedPrincipal => this["authorized_principal"];

}
