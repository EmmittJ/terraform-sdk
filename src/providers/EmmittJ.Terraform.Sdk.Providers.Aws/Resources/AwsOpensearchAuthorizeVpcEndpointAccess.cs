using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opensearch_authorize_vpc_endpoint_access resource.
/// </summary>
public class AwsOpensearchAuthorizeVpcEndpointAccess : TerraformResource
{
    public AwsOpensearchAuthorizeVpcEndpointAccess(string name) : base("aws_opensearch_authorize_vpc_endpoint_access", name)
    {
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Account is required")]
    [TerraformPropertyName("account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Account { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The authorized_principal attribute.
    /// </summary>
    [TerraformPropertyName("authorized_principal")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AuthorizedPrincipal => new TerraformReference(this, "authorized_principal");

}
