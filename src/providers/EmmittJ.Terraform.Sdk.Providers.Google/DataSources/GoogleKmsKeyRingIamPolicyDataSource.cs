using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_key_ring_iam_policy.
/// </summary>
public class GoogleKmsKeyRingIamPolicyDataSource : TerraformDataSource
{
    public GoogleKmsKeyRingIamPolicyDataSource(string name) : base("google_kms_key_ring_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("etag");
        this.WithOutput("policy_data");
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
    /// The key_ring_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRingId is required")]
    public required TerraformProperty<string> KeyRingId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_ring_id");
        set => this.WithProperty("key_ring_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
