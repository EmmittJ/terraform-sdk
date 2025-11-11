using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsDbInstancesDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_db_instances.
/// </summary>
public class AwsDbInstancesDataSource : TerraformDataSource
{
    public AwsDbInstancesDataSource(string name) : base("aws_db_instances", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsDbInstancesDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The instance_arns attribute.
    /// </summary>
    [TerraformPropertyName("instance_arns")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InstanceArns => new TerraformReference(this, "instance_arns");

    /// <summary>
    /// The instance_identifiers attribute.
    /// </summary>
    [TerraformPropertyName("instance_identifiers")]
    // Output-only attribute - read-only reference
    public TerraformList<string> InstanceIdentifiers => new TerraformReference(this, "instance_identifiers");

}
