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
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_on_demand_capacity");
        set => this.WithProperty("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetSpotCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_spot_capacity");
        set => this.WithProperty("target_spot_capacity", value);
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
