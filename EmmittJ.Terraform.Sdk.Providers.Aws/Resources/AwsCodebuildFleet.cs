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
    public double? BaseCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("base_capacity")?.Value;
        set => this.WithProperty("base_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public string? ComputeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_type")?.Value;
        set => this.WithProperty("compute_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    public string? EnvironmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment_type")?.Value;
        set => this.WithProperty("environment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public string? FleetServiceRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_service_role")?.Value;
        set => this.WithProperty("fleet_service_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public string? ImageId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_id")?.Value;
        set => this.WithProperty("image_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The overflow_behavior attribute.
    /// </summary>
    public string? OverflowBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("overflow_behavior")?.Value;
        set => this.WithProperty("overflow_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
