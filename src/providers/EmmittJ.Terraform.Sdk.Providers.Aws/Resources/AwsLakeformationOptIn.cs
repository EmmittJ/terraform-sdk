using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInConditionBlock
{

}

/// <summary>
/// Block type for principal in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInPrincipalBlock
{
    /// <summary>
    /// The data_lake_principal_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLakePrincipalIdentifier is required")]
    [TerraformPropertyName("data_lake_principal_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataLakePrincipalIdentifier { get; set; }

}

/// <summary>
/// Block type for resource_data in .
/// Nesting mode: list
/// </summary>
public class AwsLakeformationOptInResourceDataBlock
{
}

/// <summary>
/// Manages a aws_lakeformation_opt_in resource.
/// </summary>
public class AwsLakeformationOptIn : TerraformResource
{
    public AwsLakeformationOptIn(string name) : base("aws_lakeformation_opt_in", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("condition")]
    public TerraformList<TerraformBlock<AwsLakeformationOptInConditionBlock>>? Condition { get; set; }

    /// <summary>
    /// Block for principal.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("principal")]
    public TerraformList<TerraformBlock<AwsLakeformationOptInPrincipalBlock>>? Principal { get; set; }

    /// <summary>
    /// Block for resource_data.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("resource_data")]
    public TerraformList<TerraformBlock<AwsLakeformationOptInResourceDataBlock>>? ResourceData { get; set; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The last_updated_by attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastUpdatedBy => new TerraformReference(this, "last_updated_by");

}
