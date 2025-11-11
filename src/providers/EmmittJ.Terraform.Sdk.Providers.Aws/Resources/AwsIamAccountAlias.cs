using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_account_alias resource.
/// </summary>
public partial class AwsIamAccountAlias : TerraformResource
{
    public AwsIamAccountAlias(string name) : base("aws_iam_account_alias", name)
    {
    }

    /// <summary>
    /// The account_alias attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountAlias is required")]
    [TerraformProperty("account_alias")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountAlias { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

}
