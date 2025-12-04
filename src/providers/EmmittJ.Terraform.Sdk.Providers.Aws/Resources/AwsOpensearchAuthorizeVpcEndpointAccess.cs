using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_opensearch_authorize_vpc_endpoint_access Terraform resource.
/// Manages a aws_opensearch_authorize_vpc_endpoint_access resource.
/// </summary>
public partial class AwsOpensearchAuthorizeVpcEndpointAccess(string name) : TerraformResource("aws_opensearch_authorize_vpc_endpoint_access", name)
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Account is required")]
    public required TerraformValue<string> Account
    {
        get => GetArgument<TerraformValue<string>>("account");
        set => SetArgument("account", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The authorized_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthorizedPrincipal
        => AsReference("authorized_principal");

}
