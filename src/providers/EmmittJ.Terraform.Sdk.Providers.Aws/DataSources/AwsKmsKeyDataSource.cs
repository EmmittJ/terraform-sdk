using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_key.
/// </summary>
public class AwsKmsKeyDataSource : TerraformDataSource
{
    public AwsKmsKeyDataSource(string name) : base("aws_kms_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_account_id");
        this.DeclareOutput("cloud_hsm_cluster_id");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("custom_key_store_id");
        this.DeclareOutput("customer_master_key_spec");
        this.DeclareOutput("deletion_date");
        this.DeclareOutput("description");
        this.DeclareOutput("enabled");
        this.DeclareOutput("expiration_model");
        this.DeclareOutput("key_manager");
        this.DeclareOutput("key_spec");
        this.DeclareOutput("key_state");
        this.DeclareOutput("key_usage");
        this.DeclareOutput("multi_region");
        this.DeclareOutput("multi_region_configuration");
        this.DeclareOutput("origin");
        this.DeclareOutput("pending_deletion_window_in_days");
        this.DeclareOutput("valid_to");
        this.DeclareOutput("xks_key_configuration");
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GrantTokens
    {
        get => GetProperty<List<TerraformProperty<string>>>("grant_tokens");
        set => this.WithProperty("grant_tokens", value);
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
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformExpression AwsAccountId => this["aws_account_id"];

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformExpression CloudHsmClusterId => this["cloud_hsm_cluster_id"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformExpression CustomKeyStoreId => this["custom_key_store_id"];

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformExpression CustomerMasterKeySpec => this["customer_master_key_spec"];

    /// <summary>
    /// The deletion_date attribute.
    /// </summary>
    public TerraformExpression DeletionDate => this["deletion_date"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The expiration_model attribute.
    /// </summary>
    public TerraformExpression ExpirationModel => this["expiration_model"];

    /// <summary>
    /// The key_manager attribute.
    /// </summary>
    public TerraformExpression KeyManager => this["key_manager"];

    /// <summary>
    /// The key_spec attribute.
    /// </summary>
    public TerraformExpression KeySpec => this["key_spec"];

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    public TerraformExpression KeyState => this["key_state"];

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformExpression KeyUsage => this["key_usage"];

    /// <summary>
    /// The multi_region attribute.
    /// </summary>
    public TerraformExpression MultiRegion => this["multi_region"];

    /// <summary>
    /// The multi_region_configuration attribute.
    /// </summary>
    public TerraformExpression MultiRegionConfiguration => this["multi_region_configuration"];

    /// <summary>
    /// The origin attribute.
    /// </summary>
    public TerraformExpression Origin => this["origin"];

    /// <summary>
    /// The pending_deletion_window_in_days attribute.
    /// </summary>
    public TerraformExpression PendingDeletionWindowInDays => this["pending_deletion_window_in_days"];

    /// <summary>
    /// The valid_to attribute.
    /// </summary>
    public TerraformExpression ValidTo => this["valid_to"];

    /// <summary>
    /// The xks_key_configuration attribute.
    /// </summary>
    public TerraformExpression XksKeyConfiguration => this["xks_key_configuration"];

}
