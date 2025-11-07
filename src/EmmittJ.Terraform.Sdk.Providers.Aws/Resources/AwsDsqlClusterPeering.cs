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
    public TerraformProperty<HashSet<string>>? Clusters
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("clusters");
        set => this.WithProperty("clusters", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string>? Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => this.WithProperty("identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The witness_region attribute.
    /// </summary>
    public TerraformProperty<string>? WitnessRegion
    {
        get => GetProperty<TerraformProperty<string>>("witness_region");
        set => this.WithProperty("witness_region", value);
    }

}
