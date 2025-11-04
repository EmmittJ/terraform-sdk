using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_guardduty_invite_accepter resource.
/// </summary>
public class AwsGuarddutyInviteAccepter : TerraformResource
{
    public AwsGuarddutyInviteAccepter(string name) : base("aws_guardduty_invite_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public string? DetectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_id")?.Value;
        set => this.WithProperty("detector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The master_account_id attribute.
    /// </summary>
    public string? MasterAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("master_account_id")?.Value;
        set => this.WithProperty("master_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
