using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2ManagedPrefixListDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEc2ManagedPrefixListDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_managed_prefix_list.
/// </summary>
public partial class AwsEc2ManagedPrefixListDataSource : TerraformDataSource
{
    public AwsEc2ManagedPrefixListDataSource(string name) : base("aws_ec2_managed_prefix_list", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsEc2ManagedPrefixListDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEc2ManagedPrefixListDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The address_family attribute.
    /// </summary>
    [TerraformProperty("address_family")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AddressFamily { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The entries attribute.
    /// </summary>
    [TerraformProperty("entries")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Entries { get; }

    /// <summary>
    /// The max_entries attribute.
    /// </summary>
    [TerraformProperty("max_entries")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxEntries { get; }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    [TerraformProperty("owner_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerId { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Version { get; }

}
