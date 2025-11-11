using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsRamResourceShareDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ram_resource_share.
/// </summary>
public partial class AwsRamResourceShareDataSource : TerraformDataSource
{
    public AwsRamResourceShareDataSource(string name) : base("aws_ram_resource_share", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceOwner is required")]
    [TerraformProperty("resource_owner")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceOwner { get; set; }

    /// <summary>
    /// The resource_share_status attribute.
    /// </summary>
    [TerraformProperty("resource_share_status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceShareStatus { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<TerraformBlock<AwsRamResourceShareDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The owning_account_id attribute.
    /// </summary>
    [TerraformProperty("owning_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwningAccountId { get; }

    /// <summary>
    /// The resource_arns attribute.
    /// </summary>
    [TerraformProperty("resource_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ResourceArns { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
