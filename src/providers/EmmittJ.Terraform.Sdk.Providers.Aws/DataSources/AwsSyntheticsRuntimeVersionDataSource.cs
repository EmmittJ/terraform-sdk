using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_synthetics_runtime_version.
/// </summary>
public class AwsSyntheticsRuntimeVersionDataSource : TerraformDataSource
{
    public AwsSyntheticsRuntimeVersionDataSource(string name) : base("aws_synthetics_runtime_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("deprecation_date");
        this.WithOutput("description");
        this.WithOutput("id");
        this.WithOutput("release_date");
        this.WithOutput("version_name");
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformProperty<bool>? Latest
    {
        get => GetProperty<TerraformProperty<bool>>("latest");
        set => this.WithProperty("latest", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformProperty<string> Prefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("prefix");
        set => this.WithProperty("prefix", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The deprecation_date attribute.
    /// </summary>
    public TerraformExpression DeprecationDate => this["deprecation_date"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The release_date attribute.
    /// </summary>
    public TerraformExpression ReleaseDate => this["release_date"];

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    public TerraformExpression VersionName => this["version_name"];

}
