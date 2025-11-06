using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image_recipe.
/// </summary>
public class AwsImagebuilderImageRecipeDataSource : TerraformDataSource
{
    public AwsImagebuilderImageRecipeDataSource(string name) : base("aws_imagebuilder_image_recipe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ami_tags");
        this.DeclareOutput("block_device_mapping");
        this.DeclareOutput("component");
        this.DeclareOutput("date_created");
        this.DeclareOutput("description");
        this.DeclareOutput("name");
        this.DeclareOutput("owner");
        this.DeclareOutput("parent_image");
        this.DeclareOutput("platform");
        this.DeclareOutput("user_data_base64");
        this.DeclareOutput("version");
        this.DeclareOutput("working_directory");
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
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    public TerraformExpression AmiTags => this["ami_tags"];

    /// <summary>
    /// The block_device_mapping attribute.
    /// </summary>
    public TerraformExpression BlockDeviceMapping => this["block_device_mapping"];

    /// <summary>
    /// The component attribute.
    /// </summary>
    public TerraformExpression Component => this["component"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    public TerraformExpression ParentImage => this["parent_image"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformExpression UserDataBase64 => this["user_data_base64"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformExpression WorkingDirectory => this["working_directory"];

}
