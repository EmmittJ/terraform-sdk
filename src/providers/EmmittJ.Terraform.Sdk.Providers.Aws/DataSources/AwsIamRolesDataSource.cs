using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_roles.
/// </summary>
public class AwsIamRolesDataSource : TerraformDataSource
{
    public AwsIamRolesDataSource(string name) : base("aws_iam_roles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NameRegex { get; set; }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    [TerraformPropertyName("path_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PathPrefix { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformPropertyName("arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Arns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "arns");

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformPropertyName("names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Names => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "names");

}
