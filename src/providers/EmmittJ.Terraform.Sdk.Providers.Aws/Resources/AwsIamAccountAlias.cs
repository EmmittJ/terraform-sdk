using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_account_alias resource.
/// </summary>
public class AwsIamAccountAlias : TerraformResource
{
    public AwsIamAccountAlias(string name) : base("aws_iam_account_alias", name)
    {
    }

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAlias is required")]
    [TerraformPropertyName("account_alias")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountAlias { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

}
