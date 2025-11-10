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
        SetOutput("authorized_principal");
        SetOutput("account");
        SetOutput("domain_name");
        SetOutput("region");
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Account is required")]
    public required TerraformProperty<string> Account
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account");
        set => SetProperty("account", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The authorized_principal attribute.
    /// </summary>
    public TerraformExpression AuthorizedPrincipal => this["authorized_principal"];

}
