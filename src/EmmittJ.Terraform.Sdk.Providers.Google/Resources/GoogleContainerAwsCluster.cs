using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterAuthorizationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for binary_authorization in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterBinaryAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Mode of operation for Binary Authorization policy evaluation. Possible values: DISABLED, PROJECT_SINGLETON_POLICY_ENFORCE
    /// </summary>
    public TerraformProperty<string>? EvaluationMode
    {
        get => GetProperty<TerraformProperty<string>>("evaluation_mode");
        set => WithProperty("evaluation_mode", value);
    }

}

/// <summary>
/// Block type for control_plane in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterControlPlaneBlock : TerraformBlock
{
    /// <summary>
    /// The name of the AWS IAM instance pofile to assign to each control plane replica.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamInstanceProfile is required")]
    public required TerraformProperty<string> IamInstanceProfile
    {
        get => GetProperty<TerraformProperty<string>>("iam_instance_profile");
        set => WithProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// Optional. The AWS instance type. When unspecified, it defaults to `m5.large`.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// Optional. The IDs of additional security groups to add to control plane replicas. The Anthos Multi-Cloud API will automatically create and manage security groups with the minimum rules needed for a functioning cluster.
    /// </summary>
    public List<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The list of subnets where control plane replicas will run. A replica will be provisioned on each subnet and up to three values can be provided. Each subnet must be in a different AWS Availability Zone (AZ).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public List<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// Optional. A set of AWS resource tags to propagate to all underlying managed AWS resources. Specify at most 50 pairs containing alphanumerics, spaces, and symbols (.+-=_:@/). Keys can be up to 127 Unicode characters. Values can be up to 255 Unicode characters.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The Kubernetes version to run on control plane replicas (e.g. `1.19.10-gke.1000`). You can list all supported versions on a given Google Cloud region by calling .
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for fleet in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterFleetBlock : TerraformBlock
{
    /// <summary>
    /// The name of the managed Hub Membership resource associated to this cluster. Membership names are formatted as projects/&amp;lt;project-number&amp;gt;/locations/global/membership/&amp;lt;cluster-id&amp;gt;.
    /// </summary>
    public TerraformProperty<string>? Membership
    {
        get => GetProperty<TerraformProperty<string>>("membership");
        set => WithProperty("membership", value);
    }

    /// <summary>
    /// The number of the Fleet host project where this cluster will be registered.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => WithProperty("project", value);
    }

}

/// <summary>
/// Block type for networking in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAwsClusterNetworkingBlock : TerraformBlock
{
    /// <summary>
    /// Disable the per node pool subnet security group rules on the control plane security group. When set to true, you must also provide one or more security groups that ensure node pools are able to send requests to the control plane on TCP/443 and TCP/8132. Failure to do so may result in unavailable node pools.
    /// </summary>
    public TerraformProperty<bool>? PerNodePoolSgRulesDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("per_node_pool_sg_rules_disabled");
        set => WithProperty("per_node_pool_sg_rules_disabled", value);
    }

    /// <summary>
    /// All pods in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PodAddressCidrBlocks is required")]
    public List<TerraformProperty<string>>? PodAddressCidrBlocks
    {
        get => GetProperty<List<TerraformProperty<string>>>("pod_address_cidr_blocks");
        set => WithProperty("pod_address_cidr_blocks", value);
    }

    /// <summary>
    /// All services in the cluster are assigned an RFC1918 IPv4 address from these ranges. Only a single range is supported. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAddressCidrBlocks is required")]
    public List<TerraformProperty<string>>? ServiceAddressCidrBlocks
    {
        get => GetProperty<List<TerraformProperty<string>>>("service_address_cidr_blocks");
        set => WithProperty("service_address_cidr_blocks", value);
    }

    /// <summary>
    /// The VPC associated with the cluster. All component clusters (i.e. control plane and node pools) run on a single VPC. This field cannot be changed after creation.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAwsClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_container_aws_cluster resource.
/// </summary>
public class GoogleContainerAwsCluster : TerraformResource
{
    public GoogleContainerAwsCluster(string name) : base("google_container_aws_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("etag");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("workload_identity_config");
    }

    /// <summary>
    /// Optional. Annotations on the cluster. This field has the same restrictions as Kubernetes annotations. The total size of all keys and values combined is limited to 256k. Key can have 2 segments: prefix (optional) and name (required), separated by a slash (/). Prefix must be a DNS subdomain. Name must be 63 characters or less, begin and end with alphanumerics, with dashes (-), underscores (_), dots (.), and alphanumerics between.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field `effective_annotations` for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The AWS region where the cluster runs. Each Google Cloud region supports a subset of nearby AWS regions. You can call to list all supported AWS regions within a given Google Cloud region.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRegion is required")]
    public required TerraformProperty<string> AwsRegion
    {
        get => GetProperty<TerraformProperty<string>>("aws_region");
        set => this.WithProperty("aws_region", value);
    }

    /// <summary>
    /// Optional. A human readable description of this cluster. Cannot be longer than 255 UTF-8 encoded bytes.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of this resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authorization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authorization block(s) allowed")]
    public List<GoogleContainerAwsClusterAuthorizationBlock>? Authorization
    {
        get => GetProperty<List<GoogleContainerAwsClusterAuthorizationBlock>>("authorization");
        set => this.WithProperty("authorization", value);
    }

    /// <summary>
    /// Block for binary_authorization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BinaryAuthorization block(s) allowed")]
    public List<GoogleContainerAwsClusterBinaryAuthorizationBlock>? BinaryAuthorization
    {
        get => GetProperty<List<GoogleContainerAwsClusterBinaryAuthorizationBlock>>("binary_authorization");
        set => this.WithProperty("binary_authorization", value);
    }

    /// <summary>
    /// Block for control_plane.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ControlPlane block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ControlPlane block(s) allowed")]
    public List<GoogleContainerAwsClusterControlPlaneBlock>? ControlPlane
    {
        get => GetProperty<List<GoogleContainerAwsClusterControlPlaneBlock>>("control_plane");
        set => this.WithProperty("control_plane", value);
    }

    /// <summary>
    /// Block for fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Fleet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Fleet block(s) allowed")]
    public List<GoogleContainerAwsClusterFleetBlock>? Fleet
    {
        get => GetProperty<List<GoogleContainerAwsClusterFleetBlock>>("fleet");
        set => this.WithProperty("fleet", value);
    }

    /// <summary>
    /// Block for networking.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networking block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Networking block(s) allowed")]
    public List<GoogleContainerAwsClusterNetworkingBlock>? Networking
    {
        get => GetProperty<List<GoogleContainerAwsClusterNetworkingBlock>>("networking");
        set => this.WithProperty("networking", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAwsClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContainerAwsClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time at which this cluster was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// Output only. The endpoint of the cluster&#39;s API server.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// Allows clients to perform consistent read-modify-writes through optimistic concurrency control. May be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. If set, there are currently changes in flight to the cluster.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Output only. The current state of the cluster. Possible values: STATE_UNSPECIFIED, PROVISIONING, RUNNING, RECONCILING, STOPPING, ERROR, DEGRADED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. A globally unique identifier for the cluster.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time at which this cluster was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Output only. Workload Identity settings.
    /// </summary>
    public TerraformExpression WorkloadIdentityConfig => this["workload_identity_config"];

}
