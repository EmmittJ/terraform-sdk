using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_emr_instance_fleet resource.
/// </summary>
public class AwsEmrInstanceFleet : TerraformResource
{
    public AwsEmrInstanceFleet(string name) : base("aws_emr_instance_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("provisioned_on_demand_capacity");
        this.DeclareOutput("provisioned_spot_capacity");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public double? TargetOnDemandCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("target_on_demand_capacity")?.Value;
        set => this.WithProperty("target_on_demand_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public double? TargetSpotCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("target_spot_capacity")?.Value;
        set => this.WithProperty("target_spot_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformExpression ProvisionedOnDemandCapacity => this["provisioned_on_demand_capacity"];

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformExpression ProvisionedSpotCapacity => this["provisioned_spot_capacity"];

}
