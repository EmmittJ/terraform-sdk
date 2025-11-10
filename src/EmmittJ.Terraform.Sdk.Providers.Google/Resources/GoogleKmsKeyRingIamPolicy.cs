using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_kms_key_ring_iam_policy resource.
/// </summary>
public class GoogleKmsKeyRingIamPolicy : TerraformResource
{
    public GoogleKmsKeyRingIamPolicy(string name) : base("google_kms_key_ring_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
        get => GetProperty<TerraformProperty<string>>("key_ring_id");
        set => this.WithProperty("key_ring_id", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetProperty<TerraformProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
