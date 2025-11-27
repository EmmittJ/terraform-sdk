using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kms_custom_key_store Terraform data source.
/// Retrieves information about a aws_kms_custom_key_store.
/// </summary>
public partial class AwsKmsCustomKeyStoreDataSource(string name) : TerraformDataSource("aws_kms_custom_key_store", name)
{
    /// <summary>
    /// The custom_key_store_id attribute.
    /// </summary>
    public TerraformValue<string> CustomKeyStoreId
    {
        get => new TerraformReference<string>(this, "custom_key_store_id");
        set => SetArgument("custom_key_store_id", value);
    }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    public TerraformValue<string> CustomKeyStoreName
    {
        get => new TerraformReference<string>(this, "custom_key_store_name");
        set => SetArgument("custom_key_store_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformValue<string> CloudHsmClusterId
    {
        get => new TerraformReference<string>(this, "cloud_hsm_cluster_id");
    }

    /// <summary>
    /// The connection_state attribute.
    /// </summary>
    public TerraformValue<string> ConnectionState
    {
        get => new TerraformReference<string>(this, "connection_state");
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    public TerraformValue<string> TrustAnchorCertificate
    {
        get => new TerraformReference<string>(this, "trust_anchor_certificate");
    }

}
