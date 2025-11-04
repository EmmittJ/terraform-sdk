using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_data_repository_association resource.
/// </summary>
public class AwsFsxDataRepositoryAssociation : TerraformResource
{
    public AwsFsxDataRepositoryAssociation(string name) : base("aws_fsx_data_repository_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("association_id");
    }

    /// <summary>
    /// The batch_import_meta_data_on_create attribute.
    /// </summary>
    public bool? BatchImportMetaDataOnCreate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("batch_import_meta_data_on_create")?.Value;
        set => this.WithProperty("batch_import_meta_data_on_create", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    public string? DataRepositoryPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_repository_path")?.Value;
        set => this.WithProperty("data_repository_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delete_data_in_filesystem attribute.
    /// </summary>
    public bool? DeleteDataInFilesystem
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_data_in_filesystem")?.Value;
        set => this.WithProperty("delete_data_in_filesystem", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public string? FileSystemId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_id")?.Value;
        set => this.WithProperty("file_system_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    public string? FileSystemPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_system_path")?.Value;
        set => this.WithProperty("file_system_path", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public double? ImportedFileChunkSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("imported_file_chunk_size")?.Value;
        set => this.WithProperty("imported_file_chunk_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

}
