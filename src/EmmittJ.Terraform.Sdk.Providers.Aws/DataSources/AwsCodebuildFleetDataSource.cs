using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codebuild_fleet.
/// </summary>
public class AwsCodebuildFleetDataSource : TerraformDataSource
{
    public AwsCodebuildFleetDataSource(string name) : base("aws_codebuild_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("base_capacity");
        this.DeclareOutput("compute_configuration");
        this.DeclareOutput("compute_type");
        this.DeclareOutput("created");
        this.DeclareOutput("environment_type");
        this.DeclareOutput("fleet_service_role");
        this.DeclareOutput("id");
        this.DeclareOutput("image_id");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("overflow_behavior");
        this.DeclareOutput("scaling_configuration");
        this.DeclareOutput("status");
        this.DeclareOutput("vpc_config");
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    public TerraformExpression BaseCapacity => this["base_capacity"];

    /// <summary>
    /// The compute_configuration attribute.
    /// </summary>
    public TerraformExpression ComputeConfiguration => this["compute_configuration"];

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformExpression ComputeType => this["compute_type"];

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformExpression Created => this["created"];

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    public TerraformExpression EnvironmentType => this["environment_type"];

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public TerraformExpression FleetServiceRole => this["fleet_service_role"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformExpression ImageId => this["image_id"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    public TerraformExpression OverflowBehavior => this["overflow_behavior"];

    /// <summary>
    /// The scaling_configuration attribute.
    /// </summary>
    public TerraformExpression ScalingConfiguration => this["scaling_configuration"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformExpression VpcConfig => this["vpc_config"];

}
