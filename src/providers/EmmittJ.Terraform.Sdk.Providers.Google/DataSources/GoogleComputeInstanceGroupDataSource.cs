using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_group.
/// </summary>
public partial class GoogleComputeInstanceGroupDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGroupDataSource(string name) : base("google_compute_instance_group", name)
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
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SelfLink { get; set; }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Instances { get; }

    /// <summary>
    /// The named_port attribute.
    /// </summary>
    [TerraformProperty("named_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NamedPort { get; }

    /// <summary>
    /// The network attribute.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Network { get; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Size { get; }

}
