using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationOptInConditionBlock() : TerraformBlock("condition")
{

}

/// <summary>
/// Block type for principal in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationOptInPrincipalBlock() : TerraformBlock("principal")
{
    /// <summary>
    /// The data_lake_principal_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataLakePrincipalIdentifier is required")]
    [TerraformProperty("data_lake_principal_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataLakePrincipalIdentifier { get; set; }

}

/// <summary>
/// Block type for resource_data in .
/// Nesting mode: list
/// </summary>
public partial class AwsLakeformationOptInResourceDataBlock() : TerraformBlock("resource_data")
{
}

/// <summary>
/// Manages a aws_lakeformation_opt_in resource.
/// </summary>
public partial class AwsLakeformationOptIn : TerraformResource
{
    public AwsLakeformationOptIn(string name) : base("aws_lakeformation_opt_in", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("condition")]
    public TerraformList<AwsLakeformationOptInConditionBlock> Condition { get; set; } = new();

    /// <summary>
    /// Block for principal.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("principal")]
    public TerraformList<AwsLakeformationOptInPrincipalBlock> Principal { get; set; } = new();

    /// <summary>
    /// Block for resource_data.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("resource_data")]
    public TerraformList<AwsLakeformationOptInResourceDataBlock> ResourceData { get; set; } = new();

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The last_updated_by attribute.
    /// </summary>
    [TerraformProperty("last_updated_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedBy { get; }

}
