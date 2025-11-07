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
    public TerraformProperty<bool>? CopyTagsToDataRepositoryAssociations
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags_to_data_repository_associations");
        set => this.WithProperty("copy_tags_to_data_repository_associations", value);
    }

    /// <summary>
    /// The file_cache_type attribute.
    /// </summary>
    public TerraformProperty<string>? FileCacheType
    {
        get => GetProperty<TerraformProperty<string>>("file_cache_type");
        set => this.WithProperty("file_cache_type", value);
    }

    /// <summary>
    /// The file_cache_type_version attribute.
    /// </summary>
    public TerraformProperty<string>? FileCacheTypeVersion
    {
        get => GetProperty<TerraformProperty<string>>("file_cache_type_version");
        set => this.WithProperty("file_cache_type_version", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The storage_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? StorageCapacity
    {
        get => GetProperty<TerraformProperty<double>>("storage_capacity");
        set => this.WithProperty("storage_capacity", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
