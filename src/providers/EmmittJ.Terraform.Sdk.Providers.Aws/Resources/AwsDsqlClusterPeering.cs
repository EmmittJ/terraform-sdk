using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDsqlClusterPeeringTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_dsql_cluster_peering resource.
/// </summary>
public partial class AwsDsqlClusterPeering : TerraformResource
{
    public AwsDsqlClusterPeering(string name) : base("aws_dsql_cluster_peering", name)
    {
    }

    /// <summary>
    /// The clusters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Clusters is required")]
    [TerraformProperty("clusters")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Clusters { get; set; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WitnessRegion is required")]
    [TerraformProperty("witness_region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WitnessRegion { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDsqlClusterPeeringTimeoutsBlock Timeouts { get; set; } = new();

}
