using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fsx_file_cache resource.
/// </summary>
public class AwsFsxFileCache : TerraformResource
{
    public AwsFsxFileCache(string name) : base("aws_fsx_file_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("data_repository_association_ids");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("file_cache_id");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The copy_tags_to_data_repository_associations attribute.
    /// </summary>
    public bool? CopyTagsToDataRepositoryAssociations
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("copy_tags_to_data_repository_associations")?.Value;
        set => this.WithProperty("copy_tags_to_data_repository_associations", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The file_cache_type attribute.
    /// </summary>
    public string? FileCacheType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_cache_type")?.Value;
        set => this.WithProperty("file_cache_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_cache_type_version attribute.
    /// </summary>
    public string? FileCacheTypeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_cache_type_version")?.Value;
        set => this.WithProperty("file_cache_type_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<string>? SecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_group_ids")?.Value;
        set => this.WithProperty("security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public double? StorageCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("storage_capacity")?.Value;
        set => this.WithProperty("storage_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public List<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The data_repository_association_ids attribute.
    /// </summary>
    public TerraformExpression DataRepositoryAssociationIds => this["data_repository_association_ids"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The file_cache_id attribute.
    /// </summary>
    public TerraformExpression FileCacheId => this["file_cache_id"];

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
