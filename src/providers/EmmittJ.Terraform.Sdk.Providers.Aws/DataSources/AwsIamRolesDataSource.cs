using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_roles.
/// </summary>
public partial class AwsIamRolesDataSource : TerraformDataSource
{
    public AwsIamRolesDataSource(string name) : base("aws_iam_roles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformProperty("name_regex")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    [TerraformProperty("path_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PathPrefix { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformProperty("arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Arns { get; }

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformProperty("names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Names { get; }

}
