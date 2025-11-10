using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_host_key resource.
/// </summary>
public class AwsTransferHostKey : TerraformResource
{
    public AwsTransferHostKey(string name) : base("aws_transfer_host_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("host_key_fingerprint");
        SetOutput("host_key_id");
        SetOutput("tags_all");
        SetOutput("description");
        SetOutput("host_key_body");
        SetOutput("host_key_body_wo");
        SetOutput("region");
        SetOutput("server_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The host_key_body attribute.
    /// </summary>
    public TerraformProperty<string> HostKeyBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_key_body");
        set => SetProperty("host_key_body", value);
    }

    /// <summary>
    /// The host_key_body_wo attribute.
    /// </summary>
    public TerraformProperty<string> HostKeyBodyWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_key_body_wo");
        set => SetProperty("host_key_body_wo", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformProperty<string> ServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_id");
        set => SetProperty("server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The host_key_fingerprint attribute.
    /// </summary>
    public TerraformExpression HostKeyFingerprint => this["host_key_fingerprint"];

    /// <summary>
    /// The host_key_id attribute.
    /// </summary>
    public TerraformExpression HostKeyId => this["host_key_id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
