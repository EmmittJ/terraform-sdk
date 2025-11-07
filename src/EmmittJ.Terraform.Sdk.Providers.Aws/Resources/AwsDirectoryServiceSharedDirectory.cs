using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_shared_directory resource.
/// </summary>
public class AwsDirectoryServiceSharedDirectory : TerraformResource
{
    public AwsDirectoryServiceSharedDirectory(string name) : base("aws_directory_service_shared_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("shared_directory_id");
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Method
    {
        get => GetProperty<TerraformLiteralProperty<string>>("method");
        set => this.WithProperty("method", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The shared_directory_id attribute.
    /// </summary>
    public TerraformExpression SharedDirectoryId => this["shared_directory_id"];

}
