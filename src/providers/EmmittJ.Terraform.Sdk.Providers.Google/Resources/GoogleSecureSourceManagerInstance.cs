using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for private_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerInstancePrivateConfigBlock : TerraformBlock
{
    /// <summary>
    /// CA pool resource, resource must in the format of &#39;projects/{project}/locations/{location}/caPools/{ca_pool}&#39;.
    /// </summary>
    public TerraformProperty<string>? CaPool
    {
        set => SetProperty("ca_pool", value);
    }

    /// <summary>
    /// Service Attachment for HTTP, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    public TerraformProperty<string>? HttpServiceAttachment
    {
        set => SetProperty("http_service_attachment", value);
    }

    /// <summary>
    /// &#39;Indicate if it&#39;s private instance.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsPrivate is required")]
    public required TerraformProperty<bool> IsPrivate
    {
        set => SetProperty("is_private", value);
    }

    /// <summary>
    /// Service Attachment for SSH, resource is in the format of &#39;projects/{project}/regions/{region}/serviceAttachments/{service_attachment}&#39;.
    /// </summary>
    public TerraformProperty<string>? SshServiceAttachment
    {
        set => SetProperty("ssh_service_attachment", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSecureSourceManagerInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for workforce_identity_federation_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock : TerraformBlock
{
    /// <summary>
    /// &#39;Whether Workforce Identity Federation is enabled.&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Manages a google_secure_source_manager_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSecureSourceManagerInstance : TerraformResource
{
    public GoogleSecureSourceManagerInstance(string name) : base("google_secure_source_manager_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("host_config");
        SetOutput("name");
        SetOutput("state");
        SetOutput("state_note");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("deletion_policy");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("kms_key");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The deletion policy for the instance. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned, rather than deleted. Setting &#39;DELETE&#39; deletes the resource
    /// and all its contents. Setting &#39;PREVENT&#39; prevents the resource from accidental
    /// deletion by erroring out during plan.
    /// Default is &#39;PREVENT&#39;.  Possible values are:
    ///   * DELETE
    ///   * PREVENT
    ///   * ABANDON
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name for the Instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// Customer-managed encryption key name, in the format projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    public TerraformProperty<string> KmsKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key");
        set => SetProperty("kms_key", value);
    }

    /// <summary>
    /// Labels as key value pairs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location for the Instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for private_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateConfig block(s) allowed")]
    public List<GoogleSecureSourceManagerInstancePrivateConfigBlock>? PrivateConfig
    {
        set => SetProperty("private_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSecureSourceManagerInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workforce_identity_federation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceIdentityFederationConfig block(s) allowed")]
    public List<GoogleSecureSourceManagerInstanceWorkforceIdentityFederationConfigBlock>? WorkforceIdentityFederationConfig
    {
        set => SetProperty("workforce_identity_federation_config", value);
    }

    /// <summary>
    /// Time the Instance was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A list of hostnames for this instance.
    /// </summary>
    public TerraformExpression HostConfig => this["host_config"];

    /// <summary>
    /// The resource name for the Instance.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the Instance.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Provides information about the current instance state.
    /// </summary>
    public TerraformExpression StateNote => this["state_note"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time the Instance was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
