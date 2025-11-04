using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_appstream_image.
/// </summary>
public class AwsAppstreamImageDataSource : TerraformDataSource
{
    public AwsAppstreamImageDataSource(string name) : base("aws_appstream_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("applications");
        this.DeclareOutput("appstream_agent_version");
        this.DeclareOutput("base_image_arn");
        this.DeclareOutput("created_time");
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("image_builder_name");
        this.DeclareOutput("image_builder_supported");
        this.DeclareOutput("image_permissions");
        this.DeclareOutput("platform");
        this.DeclareOutput("public_base_image_released_date");
        this.DeclareOutput("state");
        this.DeclareOutput("state_change_reason");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent")?.Value;
        set => this.WithProperty("most_recent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name_regex attribute.
    /// </summary>
    public string? NameRegex
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_regex")?.Value;
        set => this.WithProperty("name_regex", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public TerraformExpression Applications => this["applications"];

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    public TerraformExpression AppstreamAgentVersion => this["appstream_agent_version"];

    /// <summary>
    /// The base_image_arn attribute.
    /// </summary>
    public TerraformExpression BaseImageArn => this["base_image_arn"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The image_builder_name attribute.
    /// </summary>
    public TerraformExpression ImageBuilderName => this["image_builder_name"];

    /// <summary>
    /// The image_builder_supported attribute.
    /// </summary>
    public TerraformExpression ImageBuilderSupported => this["image_builder_supported"];

    /// <summary>
    /// The image_permissions attribute.
    /// </summary>
    public TerraformExpression ImagePermissions => this["image_permissions"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The public_base_image_released_date attribute.
    /// </summary>
    public TerraformExpression PublicBaseImageReleasedDate => this["public_base_image_released_date"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state_change_reason attribute.
    /// </summary>
    public TerraformExpression StateChangeReason => this["state_change_reason"];

}
