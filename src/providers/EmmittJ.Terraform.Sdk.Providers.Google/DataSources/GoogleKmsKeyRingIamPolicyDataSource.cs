using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_key_ring_iam_policy Terraform data source.
/// Retrieves information about a google_kms_key_ring_iam_policy.
/// </summary>
public partial class GoogleKmsKeyRingIamPolicyDataSource(string name) : TerraformDataSource("google_kms_key_ring_iam_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_ring_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyRingId is required")]
    public required TerraformValue<string> KeyRingId
    {
        get => GetArgument<TerraformValue<string>>("key_ring_id");
        set => SetArgument("key_ring_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
        => AsReference("policy_data");

}
