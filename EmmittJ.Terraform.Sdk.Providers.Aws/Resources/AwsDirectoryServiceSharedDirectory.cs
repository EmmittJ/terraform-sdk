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
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The method attribute.
    /// </summary>
    public string? Method
    {
        get => GetProperty<TerraformLiteralProperty<string>>("method")?.Value;
        set => this.WithProperty("method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public string? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes")?.Value;
        set => this.WithProperty("notes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_directory_id attribute.
    /// </summary>
    public TerraformExpression SharedDirectoryId => this["shared_directory_id"];

}
