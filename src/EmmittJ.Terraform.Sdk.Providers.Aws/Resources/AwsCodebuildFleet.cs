using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codebuild_fleet resource.
/// </summary>
public class AwsCodebuildFleet : TerraformResource
{
    public AwsCodebuildFleet(string name) : base("aws_codebuild_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created");
        this.DeclareOutput("id");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? BaseCapacity
    {
        get => GetProperty<TerraformProperty<double>>("base_capacity");
        set => this.WithProperty("base_capacity", value);
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeType
    {
        get => GetProperty<TerraformProperty<string>>("compute_type");
        set => this.WithProperty("compute_type", value);
    }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    public TerraformProperty<string>? EnvironmentType
    {
        get => GetProperty<TerraformProperty<string>>("environment_type");
        set => this.WithProperty("environment_type", value);
    }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public TerraformProperty<string>? FleetServiceRole
    {
        get => GetProperty<TerraformProperty<string>>("fleet_service_role");
        set => this.WithProperty("fleet_service_role", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageId
    {
        get => GetProperty<TerraformProperty<string>>("image_id");
        set => this.WithProperty("image_id", value);
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
    /// The overflow_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? OverflowBehavior
    {
        get => GetProperty<TerraformProperty<string>>("overflow_behavior");
        set => this.WithProperty("overflow_behavior", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformExpression Created => this["created"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
