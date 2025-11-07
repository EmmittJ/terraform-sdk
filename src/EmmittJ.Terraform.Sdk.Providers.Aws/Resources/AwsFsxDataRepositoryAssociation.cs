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
    public TerraformProperty<bool>? BatchImportMetaDataOnCreate
    {
        get => GetProperty<TerraformProperty<bool>>("batch_import_meta_data_on_create");
        set => this.WithProperty("batch_import_meta_data_on_create", value);
    }

    /// <summary>
    /// The data_repository_path attribute.
    /// </summary>
    public TerraformProperty<string>? DataRepositoryPath
    {
        get => GetProperty<TerraformProperty<string>>("data_repository_path");
        set => this.WithProperty("data_repository_path", value);
    }

    /// <summary>
    /// The delete_data_in_filesystem attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteDataInFilesystem
    {
        get => GetProperty<TerraformProperty<bool>>("delete_data_in_filesystem");
        set => this.WithProperty("delete_data_in_filesystem", value);
    }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemId
    {
        get => GetProperty<TerraformProperty<string>>("file_system_id");
        set => this.WithProperty("file_system_id", value);
    }

    /// <summary>
    /// The file_system_path attribute.
    /// </summary>
    public TerraformProperty<string>? FileSystemPath
    {
        get => GetProperty<TerraformProperty<string>>("file_system_path");
        set => this.WithProperty("file_system_path", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The imported_file_chunk_size attribute.
    /// </summary>
    public TerraformProperty<double>? ImportedFileChunkSize
    {
        get => GetProperty<TerraformProperty<double>>("imported_file_chunk_size");
        set => this.WithProperty("imported_file_chunk_size", value);
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
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

}
