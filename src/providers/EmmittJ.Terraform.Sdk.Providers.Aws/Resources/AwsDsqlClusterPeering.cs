using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDsqlClusterPeering.
/// Nesting mode: single
/// </summary>
public class AwsDsqlClusterPeeringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_dsql_cluster_peering Terraform resource.
/// Manages a aws_dsql_cluster_peering resource.
/// </summary>
public partial class AwsDsqlClusterPeering(string name) : TerraformResource("aws_dsql_cluster_peering", name)
{
    /// <summary>
    /// The clusters attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Clusters is required")]
    public required TerraformSet<string> Clusters
    {
        get => GetArgument<TerraformSet<string>>("clusters");
        set => SetArgument("clusters", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => GetArgument<TerraformValue<string>>("identifier");
        set => SetArgument("identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WitnessRegion is required")]
    public required TerraformValue<string> WitnessRegion
    {
        get => GetArgument<TerraformValue<string>>("witness_region");
        set => SetArgument("witness_region", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDsqlClusterPeeringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDsqlClusterPeeringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
