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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authorized_principal attribute.
    /// </summary>
    public TerraformExpression AuthorizedPrincipal => this["authorized_principal"];

}
