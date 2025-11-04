using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dsql_cluster_peering resource.
/// </summary>
public class AwsDsqlClusterPeering : TerraformResource
{
    public AwsDsqlClusterPeering(string name) : base("aws_dsql_cluster_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The clusters attribute.
    /// </summary>
    public HashSet<string>? Clusters
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("clusters")?.Value;
        set => this.WithProperty("clusters", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public string? Identifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identifier")?.Value;
        set => this.WithProperty("identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    public string? WitnessRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("witness_region")?.Value;
        set => this.WithProperty("witness_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
