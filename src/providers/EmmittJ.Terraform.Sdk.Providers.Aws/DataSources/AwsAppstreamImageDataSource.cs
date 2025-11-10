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
        this.WithOutput("applications");
        this.WithOutput("appstream_agent_version");
        this.WithOutput("base_image_arn");
        this.WithOutput("created_time");
        this.WithOutput("description");
        this.WithOutput("display_name");
        this.WithOutput("image_builder_name");
        this.WithOutput("image_builder_supported");
        this.WithOutput("image_permissions");
        this.WithOutput("platform");
        this.WithOutput("public_base_image_released_date");
        this.WithOutput("state");
        this.WithOutput("state_change_reason");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
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
    /// The name_regex attribute.
    /// </summary>
    public TerraformProperty<string>? NameRegex
    {
        get => GetProperty<TerraformProperty<string>>("name_regex");
        set => this.WithProperty("name_regex", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
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
